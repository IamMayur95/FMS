using System;
using System.IO;
using Newtonsoft.Json;
using ProtoBuf;

namespace FMS.Core.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static T Clone<T>(this T @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            var copy = JsonConvert.SerializeObject(@this, settings);
            return JsonConvert.DeserializeObject<T>(copy);
        }

        public static byte[] ProtoSerialize<T>(this T @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            byte[] result;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, @this);
                result = stream.ToArray();
            }

            return result;
        }

        public static T ProtoDeserialize<T>(this byte[] @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            using (var ms = new MemoryStream(@this))
            {
                var result = Serializer.Deserialize<T>(ms);
                return result;
            }
        }

    }
}
