using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Collections.Generic;
using GalaxyProtector;
using System.Linq;

public static class AntiDebug
{
    public static void Execute(ModuleDef module)
    {
        var typeModule = ModuleDefMD.Load(typeof(ADneed).Module);
        var cctor = module.GlobalType.FindOrCreateStaticConstructor();
        var typeDef = typeModule.ResolveTypeDef(MDToken.ToRID(typeof(ADneed).MetadataToken));
        var members = InjectHelper.Inject(typeDef, module.GlobalType, module);
        var init = (MethodDef)members.Single(method => method.Name == "Initialize");
        cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, init));
        foreach (var md in module.GlobalType.Methods)
        {
            if (md.Name != ".ctor") continue;
            module.GlobalType.Remove(md);
            break;
        }
        Form1.Print("Anti Debug Done!");
    }
}

