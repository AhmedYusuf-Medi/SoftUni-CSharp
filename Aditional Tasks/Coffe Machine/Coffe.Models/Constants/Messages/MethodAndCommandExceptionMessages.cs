using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Constants.Messages
{
    public static class MethodAndCommandMessages
    {
        public const string InvalidNumberOfArgumentsMessage = "Invalid number of arguments. Expected: {0}, Received: {1}";
        public const string CoffeIsAlreadyCreatedMesage = "---- > Sry but the coffe is already on the collection";
        public const string CoffeDoesntExistMessage = "----> Sry but the coffe does not exist in the collection.";
        public const string CollectionIsEmptyMessage = "---- > Sry but there is no coffe's to remove.";

        //ToString
        public const string ProductToString = "---->[Product type: {0}, Name: {1} , Price - {2}]";
        public const string UserToString = "---->[User type: {0}, Name: {1} , Cash - {2}]";
    }
}
