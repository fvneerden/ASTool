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
using ASTool.CacheHelper;
namespace ASTool
{
    public partial class Program
    {
        static void CreatePullCounters(Options opt, ManifestManager mc)
        {
            UInt64 InputChunks = 0;
            UInt64 OutputChunks = 0;
            UInt64 InputBytes = 0;
            UInt64 OutputBytes = 0;

            foreach (ChunkList cl in mc.AudioChunkListList)
            {
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Source", "Counters for audio source", cl.Configuration.GetSourceName(), string.Empty, "Counters for audio source");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInInputQueue", "Number of chunks in InputQueue", cl.ChunksToReadQueue.Count, string.Empty, "Number of chunks in InputQueue");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInOutputQueue", "Number of chunks in OutputQueue", cl.ChunksQueue.Count, string.Empty, "Number of chunks in OutputQueue");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksToProcess", "Number of chunks to process", cl.TotalChunks, string.Empty, "Number of chunks to process");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputChunks", "Number of Input Chunks", cl.InputChunks, string.Empty, "Number of Input Chunks");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputBytes", "Number of Input Bytes", cl.InputBytes, string.Empty, "Number of Input Bytes");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputChunks", "Number of Output Chunks", cl.OutputChunks, string.Empty, "Number of Output Chunks");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputBytes", "Number of Output Bytes", cl.OutputBytes, string.Empty, "Number of Output Bytes");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Duration", "Duration of chunks in ms", ((cl.TimeLastChunk == 0)|| (cl.TimeFirstChunk == 0) ? 0:(cl.TimeLastChunk - cl.TimeFirstChunk) / 10000), string.Empty, "Duration of current Chunks buffer");

                InputChunks += cl.InputChunks;
                OutputChunks += cl.OutputChunks;
                InputBytes += cl.InputBytes;
                OutputBytes += cl.OutputBytes;

            }
            foreach (ChunkList cl in mc.VideoChunkListList)
            {
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Source", "Counters for video source", cl.Configuration.GetSourceName(), string.Empty, "Counters for video source");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInInputQueue", "Number of chunks in InputQueue", cl.ChunksToReadQueue.Count, string.Empty, "Number of chunks in InputQueue");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInOutputQueue", "Number of chunks in OutputQueue", cl.ChunksQueue.Count, string.Empty, "Number of chunks in OutputQueue");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksToProcess", "Number of chunks to process", cl.TotalChunks, string.Empty, "Number of chunks to process");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputChunks", "Number of Input Chunks", cl.InputChunks, string.Empty, "Number of Input Chunks");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputBytes", "Number of Input Bytes", cl.InputBytes, string.Empty, "Number of Input Bytes");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputChunks", "Number of Output Chunks", cl.OutputChunks, string.Empty, "Number of Output Chunks");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputBytes", "Number of Output Bytes", cl.OutputBytes, string.Empty, "Number of Output Bytes");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Duration", "Duration of chunks in ms", ((cl.TimeLastChunk == 0) || (cl.TimeFirstChunk == 0) ? 0 : (cl.TimeLastChunk - cl.TimeFirstChunk) / 10000), string.Empty, "Duration of current Chunks buffer");
                InputChunks += cl.InputChunks;
                OutputChunks += cl.OutputChunks;
                InputBytes += cl.InputBytes;
                OutputBytes += cl.OutputBytes;
            }
            foreach (ChunkList cl in mc.TextChunkListList)
            {
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Source", "Counters for text source", cl.Configuration.GetSourceName(), string.Empty, "Counters for text source");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInInputQueue", "Number of chunks in InputQueue", cl.ChunksToReadQueue.Count, string.Empty, "Number of chunks in InputQueue");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInOutputQueue", "Number of chunks in OutputQueue", cl.ChunksQueue.Count, string.Empty, "Number of chunks in OutputQueue");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksToProcess", "Number of chunks to process", cl.TotalChunks, string.Empty, "Number of chunks to process");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputChunks", "Number of Input Chunks", cl.InputChunks, string.Empty, "Number of Input Chunks");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputBytes", "Number of Input Bytes", cl.InputBytes, string.Empty, "Number of Input Bytes");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputChunks", "Number of Output Chunks", cl.OutputChunks, string.Empty, "Number of Output Chunks");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputBytes", "Number of Output Bytes", cl.OutputBytes, string.Empty, "Number of Output Bytes");
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Duration", "Duration of chunks in ms", ((cl.TimeLastChunk == 0) || (cl.TimeFirstChunk == 0) ? 0 : (cl.TimeLastChunk - cl.TimeFirstChunk) / 10000), string.Empty, "Duration of current Chunks buffer");
                InputChunks += cl.InputChunks;
                OutputChunks += cl.OutputChunks;
                InputBytes += cl.InputBytes;
                OutputBytes += cl.OutputBytes;
            }
            opt.SetCounter(mc.StoragePath +"_Source", "Total Counters for source", opt.InputUri, string.Empty, "Total Counters for source");
            opt.SetCounter(mc.StoragePath + "_InputChunks", "Total Number of Input Chunks", InputChunks, string.Empty, "Total Number of Input Chunks");
            opt.SetCounter(mc.StoragePath + "_InputBytes", "Total Number of Input Bytes", InputBytes, string.Empty, "Total Number of Input Bytes");
            opt.SetCounter(mc.StoragePath + "_OutputChunks", "Total Number of Output Chunks", OutputChunks, string.Empty, "Total Number of Output Chunks");
            opt.SetCounter(mc.StoragePath + "_OutputBytes", "Total Number of Output Bytes", OutputBytes, string.Empty, "Total Number of Output Bytes");
            opt.SetCounter(mc.StoragePath + "_Bitrate", "Current input bitrate", (int)(InputBytes * 8 / (DateTime.Now - opt.ThreadStartTime).TotalSeconds), "b/s", "Current input bitrate");

        }
        static void UpdatePullCounters(Options opt, ManifestManager mc)
        {
            UInt64 InputChunks = 0;
            UInt64 OutputChunks = 0;
            UInt64 InputBytes = 0;
            UInt64 OutputBytes = 0;

            foreach (ChunkList cl in mc.AudioChunkListList)
            {
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Source",  cl.Configuration.GetSourceName());
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInInputQueue", cl.ChunksToReadQueue.Count);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInOutputQueue",cl.ChunksQueue.Count);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksToProcess", cl.TotalChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputChunks", cl.InputChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputBytes", cl.InputBytes);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputChunks", cl.OutputChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputBytes", cl.OutputBytes);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Duration", ((cl.TimeLastChunk == 0) || (cl.TimeFirstChunk == 0) ? 0 : (cl.TimeLastChunk - cl.TimeFirstChunk) / 10000));
                InputChunks += cl.InputChunks;
                OutputChunks += cl.OutputChunks;
                InputBytes += cl.InputBytes;
                OutputBytes += cl.OutputBytes;

            }
            foreach (ChunkList cl in mc.VideoChunkListList)
            {
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Source", cl.Configuration.GetSourceName());
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInInputQueue", cl.ChunksToReadQueue.Count);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInOutputQueue", cl.ChunksQueue.Count);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksToProcess", cl.TotalChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputChunks", cl.InputChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputBytes", cl.InputBytes);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputChunks", cl.OutputChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputBytes", cl.OutputBytes);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Duration", ((cl.TimeLastChunk == 0) || (cl.TimeFirstChunk == 0) ? 0 : (cl.TimeLastChunk - cl.TimeFirstChunk) / 10000));

                InputChunks += cl.InputChunks;
                OutputChunks += cl.OutputChunks;
                InputBytes += cl.InputBytes;
                OutputBytes += cl.OutputBytes;
            }
            foreach (ChunkList cl in mc.TextChunkListList)
            {
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Source", cl.Configuration.GetSourceName());
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInInputQueue", cl.ChunksToReadQueue.Count);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksInOutputQueue", cl.ChunksQueue.Count);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_NumberChunksToProcess", cl.TotalChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputChunks", cl.InputChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_InputBytes", cl.InputBytes);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputChunks", cl.OutputChunks);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_OutputBytes", cl.OutputBytes);
                opt.SetCounter(cl.Configuration.GetSourceName() + "_Duration", ((cl.TimeLastChunk == 0) || (cl.TimeFirstChunk == 0) ? 0 : (cl.TimeLastChunk - cl.TimeFirstChunk) / 10000));

                InputChunks += cl.InputChunks;
                OutputChunks += cl.OutputChunks;
                InputBytes += cl.InputBytes;
                OutputBytes += cl.OutputBytes;
            }
            opt.SetCounter(mc.StoragePath + "_Source", opt.InputUri);
            opt.SetCounter(mc.StoragePath + "_InputChunks", InputChunks);
            opt.SetCounter(mc.StoragePath + "_InputBytes", InputBytes);
            opt.SetCounter(mc.StoragePath + "_OutputChunks", OutputChunks);
            opt.SetCounter(mc.StoragePath + "_OutputBytes", OutputBytes);
            opt.SetCounter(mc.StoragePath + "_Bitrate", (int)(InputBytes * 8 / (DateTime.Now - opt.ThreadStartTime).TotalSeconds));

        }

        static bool Pull(Options opt)
        {
            bool result = false;
            opt.Status = Options.TheadStatus.Running ;
            opt.ThreadStartTime = DateTime.Now;
            opt.ThreadCounterTime = DateTime.Now;
            opt.LogInformation("\r\nPull " + opt.Name + "\r\n Pulling from : " + opt.InputUri + "\r\n Storing in   : " + opt.OutputUri);


            DiskCache d = new DiskCache();
            d.Initialize(opt.OutputUri);
            ManifestManager mc = ManifestManager.CreateManifestCache(new Uri(opt.InputUri), (ulong) opt.MinBitrate, (ulong)opt.MaxBitrate, opt.AudioTrackName, opt.TextTrackName, opt.MaxDuration,(ulong) opt.BufferSize, opt.LiveOffset);
            mc.SetManifestOutput(d);
            var t = d.RemoveAsset(mc);
            t.Wait();
            t = mc.DownloadManifest();
            t.Wait();
            result = t.Result;
            if (result == true)
            {
                var tt = mc.StartDownloadChunks();
                tt.Wait();
                result = tt.Result;
                while (mc.GetAssetStatus() != AssetStatus.ChunksDownloaded)
                {
                    if (opt.CounterPeriod > 0)
                    {
                        System.Threading.Tasks.Task.Delay(opt.CounterPeriod * 1000 / 10).Wait();
                        if ((opt.ListCounters == null) || (opt.ListCounters.Count == 0))
                            CreatePullCounters(opt, mc);
                        else
                            UpdatePullCounters(opt, mc);
                    }
                    else
                        System.Threading.Tasks.Task.Delay(1000).Wait();
                }
            }

            opt.LogInformation("Pull " + opt.Name + " done");
            opt.Status = Options.TheadStatus.Stopped;
            return result;
        }
    }
}
