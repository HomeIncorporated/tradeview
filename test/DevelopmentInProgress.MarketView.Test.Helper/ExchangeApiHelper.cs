﻿using DevelopmentInProgress.MarketView.Interface.Interfaces;

namespace DevelopmentInProgress.MarketView.Test.Helper
{
    public static class ExchangeApiHelper
    {
        public static IExchangeApi GetExchangeApi()
        {
            return GetExchangeApi(ExchangeApiType.Standard);
        }

        public static IExchangeApi GetExchangeApi(ExchangeApiType exchangeApiType)
        {
            switch(exchangeApiType)
            {
                case ExchangeApiType.Standard:
                    return new ExchangeApi();
                case ExchangeApiType.SubscribeAccountInfo:
                    return new ExchangeApiSubscribeAccountInfoAccount();
                case ExchangeApiType.SymbolsViewModel:
                    return new ExchangeApiSymbolsViewModel();
                case ExchangeApiType.UpdateOrders:
                    return new ExchangeApiUpdateOrders();
                case ExchangeApiType.PlaceOrderException:
                    return new ExchangeApiPlaceOrderException();
                case ExchangeApiType.SubscribeOrderBookAggregateTrades:
                    return new ExchangeApiSubscribeOrderBookAggregateTrades();
                default:
                    return new ExchangeApi();
            }
        }
    }
}
