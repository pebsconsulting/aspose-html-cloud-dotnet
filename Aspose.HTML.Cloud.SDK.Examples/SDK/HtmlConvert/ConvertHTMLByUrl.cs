﻿ using System;
using System.IO;
using Aspose.Html.Cloud.Sdk.Api;
using Aspose.Html.Cloud.Sdk.Api.Interfaces;

namespace Aspose.HTML.Cloud.Examples.SDK.HtmlConvert
{
    /// <summary>
    /// Aspose.HTML Cloud for .NET SDK - examples.
    /// =========================================
    /// Example that demonstrates how to convert HTML page by its URL to one of formats 
    /// supported by Aspose.HTML for Cloud and save it to the cloud storage.
    /// </summary>
    public class ConvertHTMLByUrl : ISdkRunner
    {
        private string Format { get; set; }

        public ConvertHTMLByUrl(string format)
        {
            Format = format;
        }

        public string FileUrl { get; set; }

        public void Run()
        {
            FileUrl = @"https://www.le.ac.uk/oerresources/bdra/html/page_01.htm";
            //FileUrl = @"https://docs.gitlab.com/ee/README.html";
            string name = "page_01.htm";
            string ext = (Format == "tiff") ? "tif" : ((Format == "jpeg") ? "jpg" : Format);
            string outFile = $"{Path.GetFileNameWithoutExtension(name)}_converted.{ext}";
            string outPath = Path.Combine(CommonSettings.OutDirectory, outFile);

            IConversionApi convApi = new ConversionApi(CommonSettings.AppKey, CommonSettings.AppSID, CommonSettings.BasePath);
            Stream response = null;
            // call SDK methods that convert HTML document to supported out format
            switch (Format)
            {
                case "pdf":
                    response = convApi.GetConvertDocumentToPdfByUrl(FileUrl, 1200, 800);
                    break;
                case "xps":
                    response = convApi.GetConvertDocumentToXps(FileUrl, 1200, 800);
                    break;
                case "jpeg":
                case "bmp":
                case "png":
                case "tiff":
                    response = convApi.GetConvertDocumentToImage(Format, FileUrl, 800, 1200);
                    break;
                default:
                    throw new ArgumentException($"Unsupported output format: {Format}");
            }

            if (response != null && response is FileStream)
            {
                using (FileStream fstr = new FileStream(outPath, FileMode.Create, FileAccess.Write))
                {
                    response.Position = 0;
                    response.CopyTo(fstr);
                    fstr.Flush();
                    Console.WriteLine(string.Format("\nResult file downloaded to: {0}", outPath));
                }
            }

        }
    }
}

