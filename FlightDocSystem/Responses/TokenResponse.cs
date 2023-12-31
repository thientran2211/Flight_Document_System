﻿namespace FlightDocSystem.Responses
{
    public class TokenResponse : BaseResponse
    {
        public string Token { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool IsAuthenticated { get; set; } = false;
    }
}
