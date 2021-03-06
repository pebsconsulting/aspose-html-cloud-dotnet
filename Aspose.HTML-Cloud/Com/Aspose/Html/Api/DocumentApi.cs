// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentApi.cs">
//   Copyright (c) 2018 Aspose.HTML for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.IO;
using System.Collections.Generic;
using Com.Aspose.Html.Client;
using Com.Aspose.Html.Api.Interfaces;
using Com.Aspose.Html.NativeClient;


namespace Com.Aspose.Html.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    [Obsolete]
    public class DocumentApi : ApiBase, IDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDocumentApi"/> class.
        /// </summary>
		/// <param name="apiKey">The api key.</param>
		/// <param name="apiSid">The api sid.</param>
        /// <param name="basePath">The base path.</param>
        public DocumentApi(String apiKey, String apiSid, String basePath)
            : base(apiKey, apiSid, basePath)
        {
        }

        /// <summary>
        /// Return the HTML document by the name from default or specified storage. 
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document folder</param>
        /// <param name="folder">The document folder.</param>
        /// <returns>System.IO.Stream | Stream containing the requested document</returns>
        public Stream GetDocument (string name, string storage, string folder)
        {
            var methodName = "GetDocument";
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetDocument");
            
    
            var path = "/html/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClientUtils.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
     
            if (storage != null) queryParams.Add("storage", ApiClientUtils.ParameterToString(storage)); // query parameter
            if (folder != null) queryParams.Add("folder", ApiClientUtils.ParameterToString(folder)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            var response = CallGetApi(path, queryParams, methodName);
            return response;
        }

        /// <summary>
        /// Return list of HTML fragments matching the specified XPath query.  
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="xPath">XPath query string.</param>
        /// <param name="outFormat">Output format. Possible values: &#39;plain&#39; and &#39;json&#39;.</param>
        /// <param name="storage">The document storage.</param>
        /// <param name="folder">The document folder.</param>
        /// <returns>System.IO.Stream | Stream containing the requested fragments</returns>
        /// 
        public Stream GetDocumentFragmentByXPath (string name, string xPath, string outFormat, string storage, string folder)
        {
            var methodName = "GetDocumentFragmentByXPath";
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentFragmentByXPath");
            
            // verify the required parameter 'xPath' is set
            if (xPath == null) throw new ApiException(400, "Missing required parameter 'xPath' when calling GetDocumentFragmentByXPath");
            
            // verify the required parameter 'outFormat' is set
            if (outFormat == null) throw new ApiException(400, "Missing required parameter 'outFormat' when calling GetDocumentFragmentByXPath");
            
    
            var path = "/html/{name}/fragments/{outFormat}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClientUtils.ParameterToString(name));
            path = path.Replace("{" + "outFormat" + "}", ApiClientUtils.ParameterToString(outFormat));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();

             if (xPath != null) queryParams.Add("xPath", ApiClientUtils.ParameterToString(xPath)); // query parameter
             if (storage != null) queryParams.Add("storage", ApiClientUtils.ParameterToString(storage)); // query parameter
             if (folder != null) queryParams.Add("folder", ApiClientUtils.ParameterToString(folder)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            var response = CallGetApi(path, queryParams, methodName);
            return response;
        }

        /// <summary>
        /// Return all HTML document images packaged as a ZIP archive. 
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage.</param>
        /// <param name="folder">The document folder.</param>
        /// <returns>System.IO.Stream | Stream containing the ZIP archive of all images.</returns>
        public Stream GetDocumentImages (string name, string storage, string folder)
        {
            var methodName = "GetDocumentImages";
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentImages");
    
            var path = "/html/{name}/images/all";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClientUtils.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
    
             if (storage != null) queryParams.Add("storage", ApiClientUtils.ParameterToString(storage)); // query parameter
             if (folder != null) queryParams.Add("folder", ApiClientUtils.ParameterToString(folder)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            var response = CallGetApi(path, queryParams, methodName);
            return response;
        }
    
    }
}
