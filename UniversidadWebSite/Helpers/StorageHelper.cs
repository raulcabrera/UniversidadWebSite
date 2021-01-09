using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage;
using Azure.Storage.Blobs;

namespace UniversidadWebSite.Helpers
{
    public class StorageHelper
    {
        public static async Task<string> SubirArchivo(Stream contenido, string nombre, AzureStorageConfig config)
        {
            var url = $"https://{config.Cuenta}.blob.core.windows.net/{config.Contenedor}/{nombre}";
            var uri = new Uri(url);
            var credenciales = new StorageSharedKeyCredential(config.Cuenta, config.Llave);

            var cliente = new BlobClient(uri, credenciales);
            await cliente.UploadAsync(contenido);
            return url;
        }
    }
}
