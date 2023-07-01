using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Collections.Generic;
using GalaxyProtector;
using System.Linq;

public static class JControlFlow
{
    public static void Execute(ModuleDefMD module)
    {
        foreach (var type in module.Types)
        {
            foreach (var method in type.Methods.ToArray())
            {
                if (!method.HasBody || !method.Body.HasInstructions || method.Body.HasExceptionHandlers) continue;
                for (var i = 0; i < method.Body.Instructions.Count - 2; i++)
                {
                    var inst = method.Body.Instructions[i + 1];
                    method.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Ldstr, RenamerPhase.GenerateString(RenamerPhase.RenameMode.Ascii)));
                    method.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Br_S, inst));
                    i += 2;
                }
            }
        }
        Form1.Print("Jump Control Flow Done!");
    }

}

