﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ASTool.ISMHelper
{
    class Mp4BoxSCHM : Mp4Box
    {
        static public Mp4BoxSCHM CreateSCHMBox(string scheme_type, Int32 scheme_version)
        {

            Mp4BoxSCHM box = new Mp4BoxSCHM();
            if ((box != null)&&(!string.IsNullOrEmpty(scheme_type)))
            {
                byte version = 0x00;
                Int32 flag = 0;
                box.Length = 8 + 4 + 4 + 4  ;
                box.Type = "schm";
                byte[] Buffer = new byte[box.Length - 8 ];
                if (Buffer != null)
                {
                    WriteMp4BoxByte(Buffer, 0, version);
                    WriteMp4BoxInt24(Buffer, 1, flag);
                    WriteMp4BoxString(Buffer, 4, scheme_type);
                    WriteMp4BoxInt32(Buffer, 8, scheme_version);
                    box.Data = Buffer;
                    return box;
                }
            }
            return null;
        }
    }
}
