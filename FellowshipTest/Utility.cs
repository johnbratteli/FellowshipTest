using System;
using System.Web.Mvc;
using System.Reflection;

namespace FellowshipTest
{
    public static class Utility
    {
        /// <summary>
        /// recursively populates a new object of the given type using values from FormCollection 
        /// collection["a"] = "foo" & collection["b.a"] = "bar" => newObj.a = "foo" & newObj.b.a = "bar"
        /// </summary>
        /// <param name="collection">The collection from which to gather values</param>
        /// <param name="type">The type of the object to fill</param>
        /// <param name="prefix">Used by recursion - leave at default</param>
        /// <returns>Object of the type given by the second argument</returns>
        public static object constructorCollectionHelper(FormCollection collection, System.Type type, string prefix = "")
        {
            PropertyInfo pInfo;
            Object output;

            if (type == typeof(string))
            {
                // string is weird
                output = System.Activator.CreateInstance(type, 'c', 0);
            }
            else
            {
                output = System.Activator.CreateInstance(type);
            }

            foreach (var property in type.GetProperties())
            {
                pInfo = type.GetProperty(property.Name);

                // check if we need to recurse
                if (property.ReflectedType.IsPrimitive)
                {
                    // this property is primitive - get the collection's value for it
                    pInfo.SetValue(output, collection[prefix + pInfo.Name], null);
                }
                else
                {
                    // recurse with the name and type of the current property
                    var newPrefix = prefix + pInfo.Name.ToLower() + ".";
                    return constructorCollectionHelper(collection, pInfo.PropertyType, newPrefix);
                }
            }

            return output;
        }
    }
}