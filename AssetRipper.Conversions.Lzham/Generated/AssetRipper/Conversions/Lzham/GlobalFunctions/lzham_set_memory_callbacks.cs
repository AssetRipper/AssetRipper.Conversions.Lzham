namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_set_memory_callbacks
{
	public unsafe static void Invoke(void* pRealloc, void* pMSize, void* pUser_data)
	{
		lzham_lib_set_memory_callbacks.Invoke(pRealloc, pMSize, pUser_data);
	}
}
