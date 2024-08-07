//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using EdiWeave.Core.ErrorCodes;

namespace EdiWeave.Framework.Exceptions
{
    class ReaderException : Exception
    {
        public ReaderErrorCode ErrorCode { get; set; }

    public ReaderException(string message, ReaderErrorCode errorCode)
        : base(message) => ErrorCode = errorCode;
  }
}
