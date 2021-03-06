﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System;

namespace Microsoft.Templates.Core
{
    public static class VersionExtensions
    {
        public static bool IsZero(this Version v)
        {
            return !(v is null) && (v.Major + v.Minor + v.Build + v.Revision) == 0;
        }

        public static bool IsNull(this Version v)
        {
            return (v is null);
        }

        public static bool IsNullOrZero(this Version v)
        {
            return (v is null) || (v.Major + v.Minor + v.Build + v.Revision) == 0;
        }
    }
}
