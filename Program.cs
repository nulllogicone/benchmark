// See https://aka.ms/new-console-template for more information
using benchmark;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");

//BenchmarkDotNet

var summary = BenchmarkRunner.Run<ShittyClass>();