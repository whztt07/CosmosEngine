﻿//------------------------------------------------------------------------------
//
//      CosmosEngine - The Lightweight Unity3D Game Develop Framework
//
//                     Version 0.9.1 (20151010)
//                     Copyright © 2011-2015
//                   MrKelly <23110388@qq.com>
//              https://github.com/mr-kelly/CosmosEngine
//
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// CosmosEngine's Module must has IEnumerator Init method
/// </summary>
public interface ICModule
{
    IEnumerator Init();
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class CDependencyClass : Attribute
{
    public CDependencyClass(Type dependencyType)
    {
          
    }
}