﻿namespace HRAdministrationAPI
{
    // Generic factory pattern class
    public static class FactoryPattern<K, T> where T: class, K, new()
    {
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}
