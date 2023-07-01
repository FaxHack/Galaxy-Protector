using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using GalaxyProtector;

static class JunkProtect
{
    public static void Execute(ModuleDef module, AssemblyDef asm)
    {
        ModuleDef manifestModule = asm.ManifestModule;
        //Importer importer = new Importer(manifestModule);
        //IMethod method = importer.Import(typeof(JunkProtect).GetMethod("Execute"));

        module.GlobalType.Name = RandomString(40);

        for (var i = 0; i < 3285; i++)//3285
        {

            TypeDef type2 = new TypeDefUser(RandomString(40));
            //type2.Methods.Add();
            type2.Attributes = TypeAttributes.Class; // Setting class attribute.
                                                     //type2.Methods.Add(method.ResolveMethodDef());
                                                     //type2.Methods.Add(method.ResolveMethodDefThrow()); // dnlib.DotNet.MemberRefResolveException: 'Could not resolve method: System.Void Obfuscator.Core.Protections.AntiDump.AntiDumpRuntime::Initialize() (Obfuscator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)'
            manifestModule.Types.Add(type2);
        }

        Form1.Print("Junk Added!");
    }

    

    private static Random random = new Random(); //STRONG RENAMER CANNOT BE DECOMPILED BY "DE4DOT"
    public static string RandomString(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

}