﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace REST_WCF_TEMPLATE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.


    //Service contract specificerer hvilke operationer/metoder/funktioner som servicen understøtter.
    [ServiceContract]
    public interface IService1
    {
        
        //Get all
        [OperationContract] //Operation Contract. Web service metode
        [WebInvoke(
                Method = "GET", //http kald get
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "movies")
        ]
        List<Movies> GetMovies(); //liste som jeg kalder GetMovies af typen Movies


        //Get by id
        [WebInvoke(
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "movie/{id}")
        ]
        Movies GetOneMovie(String id);

        //Post/create
        [WebInvoke(
                Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                //ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "movies")
        ]
        void AddMovie(Movies newMovie);

        //Delete
        [WebInvoke(
                Method = "DELETE",
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "movies?id={id}")
        ]
        Movies DeleteMovie(int id);

        //Update/Put
        [WebInvoke(
               Method = "PUT",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
               UriTemplate = "movies")
       ]
        Movies UpdateMovie(Movies myMovie);
    }

}
