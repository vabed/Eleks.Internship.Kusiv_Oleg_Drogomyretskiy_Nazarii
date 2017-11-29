using System.Collections.Generic;
using xNet;
using Newtonsoft.Json;
// It is not good practise to just copypaste code (from here https://habrahabr.ru/post/314518/)
// TODO: try to refactor this code(not only in this file, all copypasted code in project) 
// Not mandatory: try to use this lib to work with VK API https://vknet.github.io/vk/
namespace VKStatistic
{
    class VkAPI
    {
        private const string __APPID = "6270016";  //ID приложения
        private const string __VKAPIURL = "https://api.vk.com/method/";  //Ссылка для запросов
        private string _Token;  //Токен, использующийся при запросах

        public VkAPI(string AccessToken)
        {
            _Token = AccessToken;
        }

        public Dictionary<string, string> GetInformation(string UserId, string[] Fields)  //Получение заданной информации о пользователе с заданным ID 
        {
            HttpRequest GetInformation = new HttpRequest();
            GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);
            string Params = "";
            foreach (string i in Fields)
            {
                Params += i + ",";
            }
            Params = Params.Remove(Params.Length - 1);
            GetInformation.AddUrlParam("fields", Params);
            string Result = GetInformation.Get(__VKAPIURL + "users.get").ToString();
            Result = Result.Substring(13, Result.Length - 15);
            Dictionary<string, string> Dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Result);
            return Dict;
        }

        public string GetCityById(string CityId)  //Перевод ID города в название
        {
            HttpRequest GetCityById = new HttpRequest();
            GetCityById.AddUrlParam("city_ids", CityId);
            GetCityById.AddUrlParam("access_token", _Token);
            string Result = GetCityById.Get(__VKAPIURL + "database.getCitiesById").ToString();
            Result = Result.Substring(13, Result.Length - 15);
            Dictionary<string, string> Dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Result);
            return Dict["name"];
        }

        public string GetCountryById(string CountryId)  //Перевод ID страны в название
        {
            HttpRequest GetCountryById = new HttpRequest();
            GetCountryById.AddUrlParam("country_ids", CountryId);
            GetCountryById.AddUrlParam("access_token", _Token);
            string Result = GetCountryById.Get(__VKAPIURL + "database.getCountriesById").ToString();
            Result = Result.Substring(13, Result.Length - 15);
            Dictionary<string, string> Dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Result);
            return Dict["name"];
        }

        //public string GetFriendsById(string FrendsId)
        //{
        //    HttpRequest GetFriendsById = new HttpRequest();
        //    GetFriendsById.AddUrlParam("get", FrendsId);
        //    GetFriendsById.AddUrlParam("access_token", _Token);
        //    string Result = GetFriendsById.Get(__VKAPIURL + "Friends.get").ToString();
        //    Result = Result.Substring(13, Result.Length - 15);
        //    Dictionary<string, string> Dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Result);
        //    return Dict["name"];
        //}
    }
}