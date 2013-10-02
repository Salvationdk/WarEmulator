/*
 * Copyright (C) 2011 APS
 *	http://AllPrivateServer.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
 
using System;

enum Opcodes : ushort
{
    CMSG_VerifyProtocolReq          = 0x01,
    SMSG_VerifyProtocolReply        = 0x02,
    CMSG_AuthInitialTokenReq        = 0x03,
    SMSG_AuthInitialTokenReply      = 0x04,
    CMSG_AuthSessionTokenReq        = 0x05,
    SMSG_AuthSessionTokenReply      = 0x06,
    CMSG_GetCharSummaryListReq      = 0x07,
    SMSG_GetCharSummaryListReply    = 0x08,
    CMSG_GetClusterListReq          = 0x09,
    SMSG_GetClusterListReply        = 0x0a,
    CMSG_GetAcctPropListReq         = 0x0d,
    SMSG_GetAcctPropListReply       = 0x0c,
    CMSG_MetricEventNotify          = 0x0b,
    MAX_OPCODE                      = 0x0b
   
};