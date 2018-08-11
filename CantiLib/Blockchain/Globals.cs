﻿//
// Copyright (c) 2018 Canti, The TurtleCoin Developers
// 
// Please see the included LICENSE file for more information.

using Canti.Data;
using System;
using System.Collections.Generic;

namespace Canti.Blockchain
{
    public class Globals
    {
        // Daemon
        public static IBlockchainCache[] DAEMON_CHAIN_LEAVES = new IBlockchainCache[] { };
        public static uint DAEMON_BLOCK_HEIGHT = 1;
        public static string DAEMON_TOP_ID = Encoding.HexStringToString("0000000000000000000000000000000000000000000000000000000000000000");
        public static PeerlistEntry[] DAEMON_PEERLIST = new PeerlistEntry[0];

        /* What prefix does your address start with - see https://cryptonotestarter.org/tools.html */
        public static ulong addressPrefix = 0x3bbb1d; /* == TRTL */

        /* What is your coin ticker, e.g. Bitcoin = BTC, Monero = XMR */
        public static string ticker = "TRTL";

        /* The name of your coin */
        public static string coinName = "TurtleCoin";

        /* The version of your software you are currently on */
        public static string version = "v0.0.1";

        /* The name of the CLI Wallet */
        public static string CLIWalletName = "zedwallet++";
    }
}
