﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Practica_EF_Logic.Practica.EF.Logic.APIMory;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC
{
    public static class ModelsMapHelpersMorty
    {
        public static List<CharactersView> SetCharactersViewOfJsonMorty(this string stringResponse)
        {
            List<CharactersView> charcterList = new List<CharactersView>();
            JArray jsonArray = JArray.Parse(stringResponse);

              for(var i=0; i< jsonArray.Children().ToList().Count; i++)
            { 

                CharactersView newChar = new CharactersView();
                newChar.id = (int)jsonArray[i]["id"];
                newChar.name = (string)jsonArray[i]["name"];
                newChar.status = (string)jsonArray[i]["status"];
                newChar.species = (string)jsonArray[i]["species"];
                newChar.img = (string)jsonArray[i]["image"];
                charcterList.Add(newChar);
            }

            return charcterList;
        }
    }
}

