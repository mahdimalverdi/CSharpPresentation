using Presentation.Chapters.Abstraction;
using System;

namespace Presentation.Chapters.Factory
{
    public static class ChapterFactory
    {
        public const string Chapter1 = "chapter1";
        public const string Chapter2 = "chapter2";
        public const string Chapter3 = "chapter3";
        public const string Chapter4 = "chapter4";
        public const string Chapter5 = "chapter5";
        public const string Chapter6 = "chapter6";
        public const string Chapter7 = "chapter7";
        public const string Chapter8 = "chapter8";
        public const string Chapter9 = "chapter9";
        public const string Chapter10 = "chapter10";
        public const string Chapter11 = "chapter11";
        public const string Chapter12 = "chapter12";
        public const string Chapter13 = "chapter13";
        public const string Chapter14 = "chapter14";


        public static IChapter Create(string chapter)
        {
            switch (chapter.ToLower())
            {
                case Chapter1:
                    return new Chapter1();
                case Chapter2:
                    return new Chapter2();
                case Chapter3:
                    return new Chapter3();
                case Chapter4:
                    return new Chapter4();
                case Chapter5:
                    return new Chapter5();
                case Chapter6:
                    return new Chapter6();
                case Chapter7:
                    return new Chapter7();
                case Chapter8:
                    return new Chapter8();
                case Chapter9:
                    return new Chapter9();
                case Chapter10:
                    return new Chapter10();
                case Chapter11:
                    return new Chapter11();
                case Chapter12:
                    return new Chapter12();
                case Chapter13:
                    return new Chapter13();
                case Chapter14:
                    return new Chapter14();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}