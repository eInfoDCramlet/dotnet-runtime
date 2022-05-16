﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Generated by Fuzzlyn v1.5 on 2022-02-08 16:14:33
// Run on Arm64 Linux
// Seed: 10380378818647712015
// Reduced from 169.3 KiB to 0.7 KiB in 00:44:43
// Debug: Outputs 0
// Release: Outputs 1
public class C0
{
}

public struct S0
{
    public uint F2;
    public C0 F4;
    public uint F5;
    public int F7;
    public short F9;
    public S0(uint f2, int f7): this()
    {
        F7 = f7;
    }

    public int M21(uint arg0)
    {
        S0[] var0 = new S0[]{new S0(0, 0)};
        var vr1 = new S0(this.F2++, ForwardSubModOpt.M23());
        return ForwardSubModOpt.s_8.F7;
    }
}

public class ForwardSubModOpt
{
    public static IRT s_rt;
    public static uint s_2;
    public static S0 s_8 = new S0(0, 1);
    public static int Main()
    {
        s_rt = new C();
        S0 vr8 = default(S0);
        ushort vr9 = (ushort)(vr8.F2 % (ushort)vr8.M21(s_2));
        s_rt.WriteLine(vr9);
        return vr9 == 0 ? 100 : -1;
    }

    public static byte M23()
    {
        return default(byte);
    }
}

public interface IRT
{
    void WriteLine<T>(T value);
}

public class C : IRT
{
    public void WriteLine<T>(T value)
    {
        System.Console.WriteLine(value);
    }
}