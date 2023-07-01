using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Linq;
using GalaxyProtector;


public static class AntiDump
{
    public static void Execute(ModuleDef mod)
    {
        var typeModule = ModuleDefMD.Load(typeof(ADstart).Module);
        var cctor = mod.GlobalType.FindOrCreateStaticConstructor();
        var typeDef = typeModule.ResolveTypeDef(MDToken.ToRID(typeof(ADstart).MetadataToken));
        var members = InjectHelper.Inject(typeDef, mod.GlobalType, mod);
        var init = (MethodDef)members.Single(method => method.Name == "Initialize");
        cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, init));
        foreach (var md in mod.GlobalType.Methods)
        {
            if (md.Name != ".ctor") continue;
            mod.GlobalType.Remove(md);
            break;
        }
    }
}

