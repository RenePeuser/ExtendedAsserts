using System;
using System.Diagnostics.Contracts;
using Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtendedAsserts
{
    public static partial class Asserts
    {
        public static void IsNotPublic(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNotPublic());
        }

        public static void IsPublic(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNotPublic());
        }

        public static void IsNestedPublic(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNestedPublic());
        }

        public static void IsNestedPrivate(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNestedPrivate());
        }

        public static void IsNestedFamily(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNestedFamily());
        }

        public static void IsNestedAssembly(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNestedAssembly());
        }

        public static void IsNestedFamAndAssem(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNestedFamAndAssem());
        }

        public static void IsNestedFamOrAssem(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsNestedFamOrAssem());
        }

        public static void IsAutoLayout(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsAutoLayout());
        }

        public static void IsLayoutSequential(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsLayoutSequential());
        }

        public static void IsExplicitLayout(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsExplicitLayout());
        }

        public static void IsClass(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsClass());
        }

        public static void IsInterface(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsInterface());
        }

        public static void IsValueType(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsValueType());
        }

        public static void IsAbstract(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsAbstract());
        }

        public static void IsSealed(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsSealed());
        }

        public static void IsEnum(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsEnum());
        }

        public static void IsSpecialName(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsSpecialName());
        }

        public static void IsImport(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsImport());
        }

        public static void IsSerializable(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsSerializable());
        }

        public static void IsAnsiClass(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsAnsiClass());
        }

        public static void IsUnicodeClass(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsUnicodeClass());
        }

        public static void IsAutoClass(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsAutoClass());
        }

        public static void IsArray(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsArray());
        }

        public static void IsByRef(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsByRef());
        }

        public static void IsPointer(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsPointer());
        }

        public static void IsPrimitive(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsPrimitive());
        }

        public static void IsComObject(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsComObject());
        }

        public static void IsContextful(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsContextful());
        }

        public static void IsMarshalByRef(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsMarshalByRef());
        }
        public static void HasElementType(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.HasElementType());
        }

        public static void IsImmutable(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsImmutable());
        }

        public static void HasCustomAttribute<TAttribute>(object source) where TAttribute : Attribute
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.HasCustomAttribute<TAttribute>());
        }

        public static void IsTypeOf<T>(object source)
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsTypeOf<T>());
        }

        public static void IsSubClassOf<T>(object source) where T : class
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsSubClassOf<T>());
        }


        public static void IsInterfaceImplemented<T>(object source) where T : class
        {
            Contract.Requires(source.IsNotNull());
            Assert.IsTrue(source.IsInterfaceImplemented<T>());
        }
    }
}
