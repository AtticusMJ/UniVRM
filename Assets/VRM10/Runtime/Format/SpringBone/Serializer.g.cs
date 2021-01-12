// This file is generated from JsonSchema. Don't modify this source code.
using System;
using System.Collections.Generic;
using System.Linq;
using UniJSON;

namespace UniGLTF.Extensions.VRMC_springBone {

    static public class GltfSerializer
    {

        public static void SerializeTo(ref UniGLTF.glTFExtension dst, VRMC_springBone extension)
        {
            if (dst is glTFExtensionImport)
            {
                throw new NotImplementedException();
            }

            if (!(dst is glTFExtensionExport extensions))
            {
                extensions = new glTFExtensionExport();
                dst = extensions;
            }

            var f = new JsonFormatter();
            Serialize(f, extension);
            extensions.Add(VRMC_springBone.ExtensionName, f.GetStoreBytes());
        }


public static void Serialize(JsonFormatter f, VRMC_springBone value)
{
    f.BeginMap();


    if(value.Settings!=null&&value.Settings.Count()>=0){
        f.Key("settings");                
        Serialize_Settings(f, value.Settings);
    }

    if(value.Springs!=null&&value.Springs.Count()>=0){
        f.Key("springs");                
        Serialize_Springs(f, value.Springs);
    }

    f.EndMap();
}

public static void Serialize_Settings(JsonFormatter f, List<SpringSetting> value)
{
    f.BeginList();

    foreach(var item in value)
    {
    Serialize_Settings_ITEM(f, item);

    }
    f.EndList();
}

public static void Serialize_Settings_ITEM(JsonFormatter f, SpringSetting value)
{
    f.BeginMap();


    if(value.Stiffness.HasValue){
        f.Key("stiffness");                
        f.Value(value.Stiffness.GetValueOrDefault());
    }

    if(value.GravityPower.HasValue){
        f.Key("gravityPower");                
        f.Value(value.GravityPower.GetValueOrDefault());
    }

    if(value.GravityDir!=null&&value.GravityDir.Count()>=3){
        f.Key("gravityDir");                
        Serialize_GravityDir(f, value.GravityDir);
    }

    if(value.DragForce.HasValue){
        f.Key("dragForce");                
        f.Value(value.DragForce.GetValueOrDefault());
    }

    f.EndMap();
}

public static void Serialize_GravityDir(JsonFormatter f, float[] value)
{
    f.BeginList();

    foreach(var item in value)
    {
    f.Value(item);

    }
    f.EndList();
}

public static void Serialize_Springs(JsonFormatter f, List<Spring> value)
{
    f.BeginList();

    foreach(var item in value)
    {
    Serialize_Springs_ITEM(f, item);

    }
    f.EndList();
}

public static void Serialize_Springs_ITEM(JsonFormatter f, Spring value)
{
    f.BeginMap();


    if(!string.IsNullOrEmpty(value.Name)){
        f.Key("name");                
        f.Value(value.Name);
    }

    if(value.Setting.HasValue){
        f.Key("setting");                
        f.Value(value.Setting.GetValueOrDefault());
    }

    if(value.SpringRoot.HasValue){
        f.Key("springRoot");                
        f.Value(value.SpringRoot.GetValueOrDefault());
    }

    if(value.HitRadius.HasValue){
        f.Key("hitRadius");                
        f.Value(value.HitRadius.GetValueOrDefault());
    }

    if(value.Colliders!=null&&value.Colliders.Count()>=0){
        f.Key("colliders");                
        Serialize_Colliders(f, value.Colliders);
    }

    f.EndMap();
}

public static void Serialize_Colliders(JsonFormatter f, int[] value)
{
    f.BeginList();

    foreach(var item in value)
    {
    f.Value(item);

    }
    f.EndList();
}

    } // class
} // namespace
