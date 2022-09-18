﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CostumResponseDto<T>
    {
        [JsonIgnore]
        public int StatusCode { get; set; }

        public T Data { get; set; }

        public List<String> Errors { get; set; }



        public static CostumResponseDto<T> Success(int statusCode,T data)
        {
            return new CostumResponseDto<T> { StatusCode = statusCode, Data = data}; 
        }
        public static CostumResponseDto<T> Success(int statusCode)
        {
            return new CostumResponseDto<T> { StatusCode = statusCode};
        }

        public static CostumResponseDto<T> Fail(int statusCode, List<String> errors)
        {
            return new CostumResponseDto<T> { StatusCode = statusCode , Errors=errors };
        }

        public static CostumResponseDto<T> Fail(int statusCode, string error)
        {
            return new CostumResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error} };
        }

    }
}
