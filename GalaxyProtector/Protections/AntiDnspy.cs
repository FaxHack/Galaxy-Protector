using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Collections.Generic;
using GalaxyProtector;


public static class AntiDnspy
{

    public static void Execute(AssemblyDef assembly)
    {

        foreach (TypeDef type in assembly.ManifestModule.Types)
        {
            foreach (MethodDef method in type.Methods)
            {
                if (method.Body == null) continue;
                for (int x = 0; x < 100000; x++)
                {
                    method.Body.Instructions.Insert(x, new Instruction(OpCodes.Nop));
                }
            }
        }
        Form1.Print("Anti DnSpy Done!");
    }

    /*

    public static void Execute(ModuleDef module, AssemblyDef asm)
    {
        ModuleDef manifestModule = asm.ManifestModule;
        //Importer importer = new Importer(manifestModule);
        //IMethod method = importer.Import(typeof(JunkProtect).GetMethod("Execute"));

        for (var i = 0; i < 532617; i++)//3285
        {

            TypeDef type2 = new TypeDefUser("s");
            //type2.Methods.Add();
            type2.Attributes = TypeAttributes.Class; // Setting class attribute.
                                                     //type2.Methods.Add(method.ResolveMethodDef());
                                                     //type2.Methods.Add(method.ResolveMethodDefThrow()); // dnlib.DotNet.MemberRefResolveException: 'Could not resolve method: System.Void Obfuscator.Core.Protections.AntiDump.AntiDumpRuntime::Initialize() (Obfuscator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)'
            manifestModule.Types.Add(type2);
        }
    }*/
}