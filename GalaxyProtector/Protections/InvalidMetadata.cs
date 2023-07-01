using dnlib.DotNet;
using dnlib.DotNet.Emit;
using GalaxyProtector;
using System;
using System.Linq;

internal class InvalidMetadata
{
    public static void Execute(AssemblyDef asm)
    {
        var manifestModule = asm.ManifestModule;
        manifestModule.Mvid = null;
        asm.ManifestModule.Import(new FieldDefUser(RandomString(40)));
        foreach (var typeDef in manifestModule.Types)
        {
            TypeDef typeDef2 = new TypeDefUser(RandomString(40));
            typeDef2.Methods.Add(new MethodDefUser());
            typeDef2.NestedTypes.Add(new TypeDefUser(RandomString(40)));
            MethodDef item = new MethodDefUser();
            typeDef2.Methods.Add(item);
            typeDef.NestedTypes.Add(typeDef2);
            typeDef.Events.Add(new EventDefUser());
            foreach (var methodDef2 in typeDef.Methods)
            {
                if (methodDef2.Body == null) continue;
                if (string.Compare(methodDef2.ReturnType.FullName, "System.Void", StringComparison.Ordinal) != 0 || !methodDef2.HasBody ||
                    methodDef2.Body.Instructions.Count == 0) continue;
                var typeSig = asm.ManifestModule.Import(typeof(int)).ToTypeSig();
                var local = new Local(typeSig);
                var typeSig2 = asm.ManifestModule.Import(typeof(bool)).ToTypeSig();
                var local2 = new Local(typeSig2);
                methodDef2.Body.Variables.Add(local);
                methodDef2.Body.Variables.Add(local2);
                var operand = methodDef2.Body.Instructions[methodDef2.Body.Instructions.Count - 1];
                var instruction = new Instruction(OpCodes.Ret);
                var instruction2 = new Instruction(OpCodes.Ldc_I4_1);
                methodDef2.Body.Instructions.Insert(0, new Instruction(OpCodes.Ldc_I4_0));
                methodDef2.Body.Instructions.Insert(1, new Instruction(OpCodes.Stloc, local));
                methodDef2.Body.Instructions.Insert(2, new Instruction(OpCodes.Br, instruction2));
                var instruction3 = new Instruction(OpCodes.Ldloc, local);
                methodDef2.Body.Instructions.Insert(3, instruction3);
                methodDef2.Body.Instructions.Insert(4, new Instruction(OpCodes.Ldc_I4_0));
                methodDef2.Body.Instructions.Insert(5, new Instruction(OpCodes.Ceq));
                methodDef2.Body.Instructions.Insert(6, new Instruction(OpCodes.Ldc_I4_1));
                methodDef2.Body.Instructions.Insert(7, new Instruction(OpCodes.Ceq));
                methodDef2.Body.Instructions.Insert(8, new Instruction(OpCodes.Stloc, local2));
                methodDef2.Body.Instructions.Insert(9, new Instruction(OpCodes.Ldloc, local2));
                methodDef2.Body.Instructions.Insert(10, new Instruction(OpCodes.Brtrue, methodDef2.Body.Instructions[10]));
                methodDef2.Body.Instructions.Insert(11, new Instruction(OpCodes.Ret));
                methodDef2.Body.Instructions.Insert(12, new Instruction(OpCodes.Calli));
                methodDef2.Body.Instructions.Insert(13, new Instruction(OpCodes.Sizeof, operand));
                methodDef2.Body.Instructions.Insert(methodDef2.Body.Instructions.Count, instruction2);
                methodDef2.Body.Instructions.Insert(methodDef2.Body.Instructions.Count, new Instruction(OpCodes.Stloc, local2));
                methodDef2.Body.Instructions.Insert(methodDef2.Body.Instructions.Count, new Instruction(OpCodes.Br, instruction3));
                methodDef2.Body.Instructions.Insert(methodDef2.Body.Instructions.Count, instruction);
                methodDef2.Body.Instructions.Insert(methodDef2.Body.Instructions.Count, new Instruction(OpCodes.Leave, instruction3));
                var exceptionHandler = new ExceptionHandler(ExceptionHandlerType.Finally)
                {
                    HandlerStart = methodDef2.Body.Instructions[10],
                    HandlerEnd = methodDef2.Body.Instructions[11],
                    TryEnd = methodDef2.Body.Instructions[14],
                    TryStart = methodDef2.Body.Instructions[12]
                };
                if (!methodDef2.Body.HasExceptionHandlers)
                {
                    methodDef2.Body.ExceptionHandlers.Add(exceptionHandler);
                }
            }
        }
        TypeDef typeDef3 = new TypeDefUser(RandomString(40));
        FieldDef item2 = new FieldDefUser(RandomString(40), new FieldSig(manifestModule.Import(typeof(Important_png)).ToTypeSig()));
        typeDef3.Fields.Add(item2);
        typeDef3.BaseType = manifestModule.Import(typeof(Important_png));
        manifestModule.Types.Add(typeDef3);
        TypeDef typeDef4 = new TypeDefUser(RandomString(40))
        {
            IsInterface = true,
            IsSealed = true
        };
        manifestModule.Types.Add(typeDef4);
        manifestModule.TablesHeaderVersion = 257;
        Form1.Print("Invaild Metadata Done!");
    }

    private static Random random = new Random();
    public static string RandomString(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static class Important_png { }
}