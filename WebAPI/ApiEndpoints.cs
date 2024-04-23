﻿namespace WebAPI
{
    public class ApiEndpoints
    {
        private const string ApiBase = "api";
        public static class Method
        {
            private const string Base = $"{ApiBase}/PhotoAgency";
            public const string Create = Base;
            public const string Get = $"{Base}/{{id:Guid}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:Guid}}";
            public const string Delete = $"{Base}/{{id:Guid}}";
        }
    }
}
