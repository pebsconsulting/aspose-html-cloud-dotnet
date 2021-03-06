﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aspose.HTML.Cloud.Sdk.Tests.Base;

namespace Aspose.HTML.Cloud.Sdk.Tests.Conversion
{
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class ConversionByUrlTest : BaseTestContext
    {
        [TestMethod]
        public void Test_GetHtmlConvert_Pdf_UrlToStream()
        {
            string sourceUrl = @"https://stallman.org/articles/anonymous-payments-thru-phones.html";

            var response = this.ConversionApi.GetConvertDocumentToPdfByUrl(sourceUrl, 800, 1200);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.GetType() == typeof(FileStream));
            Assert.IsTrue(File.Exists(((FileStream)response).Name));
        }

        [TestMethod]
        public void Test_GetHtmlConvert_Xps_UrlToStream()
        {
            string sourceUrl = @"https://stallman.org/articles/anonymous-payments-thru-phones.html";

            var response = this.ConversionApi.GetConvertDocumentToXpsByUrl(sourceUrl, 800, 1200);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.GetType() == typeof(FileStream));
            Assert.IsTrue(File.Exists(((FileStream)response).Name));
        }

        [TestMethod]
        public void Test_GetHtmlConvert_Jpeg_UrlToStream()
        {
            string sourceUrl = @"https://stallman.org/articles/anonymous-payments-thru-phones.html";

            var response = this.ConversionApi.GetConvertDocumentToImageByUrl(
                sourceUrl, "jpeg", 800, 1200);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.GetType() == typeof(FileStream));
            Assert.IsTrue(File.Exists(((FileStream)response).Name));
        }
    }
}
