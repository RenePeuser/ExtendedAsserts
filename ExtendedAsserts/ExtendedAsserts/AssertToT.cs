using System;
using Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtendedAsserts
{
    public static partial class Asserts
    {
        public static void IsNotPublic<T>()
        {
            Assert.IsTrue(typeof(T).IsNotPublic());
        }

        public static void IsPublic<T>()
        {
            Assert.IsTrue(typeof(T).IsNotPublic());
        }

        public static void IsNestedPublic<T>()
        {
            Assert.IsTrue(typeof(T).IsNestedPublic());
        }

        public static void IsNestedPrivate<T>()
        {
            Assert.IsTrue(typeof(T).IsNestedPrivate());
        }

        public static void IsNestedFamily<T>()
        {
            Assert.IsTrue(typeof(T).IsNestedFamily());
        }

        public static void IsNestedAssembly<T>()
        {
            Assert.IsTrue(typeof(T).IsNestedAssembly());
        }

        public static void IsNestedFamAndAssem<T>()
        {
            Assert.IsTrue(typeof(T).IsNestedFamAndAssem());
        }

        public static void IsNestedFamOrAssem<T>()
        {
            Assert.IsTrue(typeof(T).IsNestedFamOrAssem());
        }

        public static void IsAutoLayout<T>()
        {
            Assert.IsTrue(typeof(T).IsAutoLayout());
        }

        public static void IsLayoutSequential<T>()
        {
            Assert.IsTrue(typeof(T).IsLayoutSequential());
        }

        public static void IsExplicitLayout<T>()
        {
            Assert.IsTrue(typeof(T).IsExplicitLayout());
        }

        public static void IsClass<T>()
        {
            Assert.IsTrue(typeof(T).IsClass());
        }

        public static void IsInterface<T>()
        {
            Assert.IsTrue(typeof(T).IsInterface());
        }

        public static void IsValueType<T>()
        {
            Assert.IsTrue(typeof(T).IsValueType());
        }

        public static void IsAbstract<T>()
        {
            Assert.IsTrue(typeof(T).IsAbstract());
        }

        public static void IsSealed<T>()
        {
            Assert.IsTrue(typeof(T).IsSealed());
        }

        public static void IsEnum<T>()
        {
            Assert.IsTrue(typeof(T).IsEnum());
        }

        public static void IsSpecialName<T>()
        {
            Assert.IsTrue(typeof(T).IsSpecialName());
        }

        public static void IsImport<T>()
        {
            Assert.IsTrue(typeof(T).IsImport());
        }

        public static void IsSerializable<T>()
        {
            Assert.IsTrue(typeof(T).IsSerializable());
        }

        public static void IsAnsiClass<T>()
        {
            Assert.IsTrue(typeof(T).IsAnsiClass());
        }

        public static void IsUnicodeClass<T>()
        {
            Assert.IsTrue(typeof(T).IsUnicodeClass());
        }

        public static void IsAutoClass<T>()
        {
            Assert.IsTrue(typeof(T).IsAutoClass());
        }

        public static void IsArray<T>()
        {
            Assert.IsTrue(typeof(T).IsArray());
        }

        public static void IsByRef<T>()
        {
            Assert.IsTrue(typeof(T).IsByRef());
        }

        public static void IsPointer<T>()
        {
            Assert.IsTrue(typeof(T).IsPointer());
        }

        public static void IsPrimitive<T>()
        {
            Assert.IsTrue(typeof(T).IsPrimitive());
        }

        public static void IsComObject<T>()
        {
            Assert.IsTrue(typeof(T).IsComObject());
        }

        public static void IsContextful<T>()
        {
            Assert.IsTrue(typeof(T).IsContextful());
        }

        public static void IsMarshalByRef<T>()
        {
            Assert.IsTrue(typeof(T).IsMarshalByRef());
        }
        public static void HasElementType<T>()
        {
            Assert.IsTrue(typeof(T).HasElementType());
        }

        public static void IsImmutable<T>()
        {

            Assert.IsTrue(typeof(T).IsImmutable());
        }

        public static void HasCustomAttribute<TSource, TAttribute>() where TSource : class where TAttribute : Attribute
        {
            Assert.IsTrue(typeof(TSource).HasCustomAttribute<TAttribute>());
        }

        public static void IsTypeOf<TSource, TExpected>()
        {
            Assert.IsTrue(typeof(TSource).IsTypeOf<TExpected>());
        }

        public static void IsSubClassOf<TSource, TSubClass>() where TSource : class where TSubClass : class
        {
            Assert.IsTrue(typeof(TSource).IsSubClassOf<TSubClass>());
        }


        public static void IsInterfaceImplemented<TSource, TInterface>() where TSource : class where TInterface : class
        {
            Assert.IsTrue(typeof(TSource).IsInterfaceImplemented<TInterface>());
        }
    }
}
