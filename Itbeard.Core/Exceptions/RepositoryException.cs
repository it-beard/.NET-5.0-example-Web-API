﻿using System;

namespace Itbeard.Core.Exceptions
{
    public class RepositoryException : Exception
    {
        public string EntityName { get;}

        public RepositoryException(string message, Exception inner, string entityName)
            : base(message, inner)
        {
            EntityName = entityName;
        }
    }
}