using Coffee.Models.Exceptions;
using Coffee.Models.Messages;
using System;
using System.Collections.Generic;

namespace Coffee.Models.Errors
{
    public static class Validator
    {
        public static void ParametersCountValidation(IList<string> parameters, int countMustbe, string message)
        {
            if (parameters.Count != countMustbe)
            {
                throw new InvalidUserInputException(message);
            }
        }

        public static void CheckIsNegativeOrZero(decimal value, string propertyName)
        {
            if (value <= 0)
            {
                throw new InvalidUserInputException(String.Format(ExceptionMessages.IntegerCannotBeZeroOrNegativeMessage, propertyName));
            }
        }

        public static void CheckValueString(string value, string propertyName)
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new InvalidUserInputException(String.Format(ExceptionMessages.InvalidStringPropertyMessage, propertyName));
            }
        }
















        //public static void CheckIsCollectionFull(int count, int capacity)
        //{
        //    if (count == capacity)
        //    {
        //        throw new InvalidUserInputException(ExceptionMessages.collectionIsFullMessage);
        //    }
        //}
        //public static void CheckDoesCollectionAlreadyContainsCoffe(ICoffe coffeToCheck, List<ICoffe> coffeCollection)
        //{
        //    if (coffeCollection.Contains(coffeToCheck))
        //    {
        //        throw new InvalidUserInputException(ExceptionMessages.coffeIsAlreadyCreatedMesage);
        //    }
        //}
        //public static void CheckDoesContainsCoffeSoCanBeRemoved(ICoffe coffeToCheck, List<ICoffe> coffeCollection)
        //{
        //    if (!coffeCollection.Contains(coffeToCheck))
        //    {
        //        throw new InvalidUserInputException(ExceptionMessages.coffeDoesntExistMessage);
        //    }
        //}
        //public static void DoesCollectionContainsElements(int count)
        //{
        //    if (count <= 0)
        //    {
        //        throw new InvalidUserInputException(ExceptionMessages.collectionIsEmptyMessage);
        //    }
        //}
    }
}
