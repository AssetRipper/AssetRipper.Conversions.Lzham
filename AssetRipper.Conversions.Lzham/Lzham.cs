using AssetRipper.Conversions.Lzham.Enumerations;
using AssetRipper.Conversions.Lzham.Structures;
using System;
using System.IO;
using lzham_z_compress_status_t = AssetRipper.Conversions.Lzham.Enumerations.unnamed_enum_qt239m;

namespace AssetRipper.Conversions.Lzham;

public static unsafe partial class Lzham
{
	public static byte[] Compress(ReadOnlySpan<byte> data)
	{
		lzham_compress_params parameters = default;
		parameters.m_struct_size = sizeof(lzham_compress_params);
		parameters.m_dict_size_log2 = 15; // 32KB dictionary, the minimum
		parameters.m_compress_flags = (int)lzham_compress_flags.LZHAM_COMP_FLAG_DETERMINISTIC_PARSING;
		lzham_lzham_compress_state* internalState = lzham_compress_init(parameters);
		if (internalState is null)
		{
			throw new InvalidOperationException("Failed to initialize LZHAM compressor.");
		}
		try
		{
			using MemoryStream memoryStream = new();
			Span<byte> buffer = stackalloc byte[65536];
			while (true)
			{
				lzham_compress_status_t status = lzham_compress(internalState, data, buffer, data.Length == 0, out uint bytesRead, out uint bytesWritten);
				memoryStream.Write(buffer[..(int)bytesWritten]);
				data = data[(int)bytesRead..];
				if (status == lzham_compress_status_t.LZHAM_COMP_STATUS_SUCCESS)
				{
					break;
				}
				else if (status is lzham_compress_status_t.LZHAM_COMP_STATUS_NEEDS_MORE_INPUT or lzham_compress_status_t.LZHAM_COMP_STATUS_HAS_MORE_OUTPUT or lzham_compress_status_t.LZHAM_COMP_STATUS_NOT_FINISHED)
				{
					continue;
				}
				else
				{
					throw new InvalidOperationException($"Compression failed with status: {status}");
				}
			}
			return memoryStream.ToArray();
		}
		finally
		{
			lzham_compress_deinit(internalState);
		}
	}

	public static byte[] Decompress(ReadOnlySpan<byte> data)
	{
		lzham_decompress_params parameters = default;
		parameters.m_struct_size = sizeof(lzham_decompress_params);
		parameters.m_dict_size_log2 = 15; // 32KB dictionary, the minimum
		lzham_lzham_decompressor* internalState = lzham_decompress_init(parameters);
		if (internalState is null)
		{
			throw new InvalidOperationException("Failed to initialize LZHAM decompressor.");
		}
		try
		{
			using MemoryStream memoryStream = new();
			Span<byte> buffer = stackalloc byte[65536];
			while (true)
			{
				lzham_decompress_status_t status = lzham_decompress(internalState, data, buffer, data.Length == 0, out uint bytesRead, out uint bytesWritten);
				memoryStream.Write(buffer[..(int)bytesWritten]);
				data = data[(int)bytesRead..];
				if (status == lzham_decompress_status_t.LZHAM_DECOMP_STATUS_SUCCESS)
				{
					break;
				}
				else if (status is lzham_decompress_status_t.LZHAM_DECOMP_STATUS_NEEDS_MORE_INPUT or lzham_decompress_status_t.LZHAM_DECOMP_STATUS_HAS_MORE_OUTPUT or lzham_decompress_status_t.LZHAM_DECOMP_STATUS_NOT_FINISHED)
				{
					continue;
				}
				else
				{
					throw new InvalidOperationException($"Decompression failed with status: {status}");
				}
			}
			return memoryStream.ToArray();
		}
		finally
		{
			lzham_decompress_deinit(internalState);
		}
	}

	public static lzham_lzham_compress_state* lzham_compress_init(lzham_compress_params parameters)
	{
		return (lzham_lzham_compress_state*)lzham_compress_init(&parameters);
	}

	public static lzham_compress_status_t lzham_compress(lzham_lzham_compress_state* pState, byte* pIn_buf, uint* pIn_buf_size, byte* pOut_buf, uint* pOut_buf_size, bool no_more_input_bytes_flag)
	{
		return (lzham_compress_status_t)lzham_compress(pState, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag ? 1 : 0);
	}

	public static lzham_compress_status_t lzham_compress(lzham_lzham_compress_state* pState, ReadOnlySpan<byte> in_buf, Span<byte> out_buf, bool no_more_input_bytes_flag, out uint bytesRead, out uint bytesWritten)
	{
		uint in_buf_size = (uint)in_buf.Length;
		uint out_buf_size = (uint)out_buf.Length;
		fixed (byte* pIn_buf = in_buf)
		fixed (byte* pOut_buf = out_buf)
		{
			lzham_compress_status_t result = lzham_compress(pState, pIn_buf, &in_buf_size, pOut_buf, &out_buf_size, no_more_input_bytes_flag);

			// lzham updates the sizes to reflect how much was actually read/written
			bytesRead = in_buf_size;
			bytesWritten = out_buf_size;
			return result;
		}
	}

	public static lzham_lzham_decompressor* lzham_decompress_init(lzham_decompress_params parameters)
	{
		return (lzham_lzham_decompressor*)lzham_decompress_init(&parameters);
	}

	public static lzham_decompress_status_t lzham_decompress(lzham_lzham_decompressor* pState, byte* pIn_buf, uint* pIn_buf_size, byte* pOut_buf, uint* pOut_buf_size, bool no_more_input_bytes_flag)
	{
		return (lzham_decompress_status_t)lzham_decompress(pState, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag ? 1 : 0);
	}

	public static lzham_decompress_status_t lzham_decompress(lzham_lzham_decompressor* pState, ReadOnlySpan<byte> in_buf, Span<byte> out_buf, bool no_more_input_bytes_flag, out uint bytesRead, out uint bytesWritten)
	{
		uint in_buf_size = (uint)in_buf.Length;
		uint out_buf_size = (uint)out_buf.Length;
		fixed (byte* pIn_buf = in_buf)
		fixed (byte* pOut_buf = out_buf)
		{
			lzham_decompress_status_t result = lzham_decompress(pState, pIn_buf, &in_buf_size, pOut_buf, &out_buf_size, no_more_input_bytes_flag);

			// lzham updates the sizes to reflect how much was actually read/written
			bytesRead = in_buf_size;
			bytesWritten = out_buf_size;
			return result;
		}
	}

	public static byte[] ZCompress(ReadOnlySpan<byte> data)
	{
		byte[] compressedData = GC.AllocateUninitializedArray<byte>(lzham_z_compressBound(data.Length));
		lzham_z_compress_status_t status = lzham_z_compress(data, compressedData, out uint bytesWritten);
		if (status != lzham_z_compress_status_t.LZHAM_Z_OK)
		{
			throw new InvalidOperationException($"Z-compression failed with status: {status}");
		}
		Array.Resize(ref compressedData, (int)bytesWritten);
		return compressedData;
	}

	public static byte[] ZDecompress(ReadOnlySpan<byte> data)
	{
		throw new NotImplementedException();
	}

	public unsafe static lzham_z_compress_status_t lzham_z_compress(byte* pDest, uint* pDest_len, byte* pSource, uint source_len)
	{
		return (lzham_z_compress_status_t)lzham_z_compress(pDest, pDest_len, pSource, unchecked((int)source_len));
	}

	public unsafe static lzham_z_compress_status_t lzham_z_compress(ReadOnlySpan<byte> source, Span<byte> destination, out uint bytesWritten)
	{
		uint dest_len = (uint)destination.Length;
		fixed (byte* pSource = source)
		fixed (byte* pDest = destination)
		{
			lzham_z_compress_status_t result = lzham_z_compress(pDest, &dest_len, pSource, (uint)source.Length);
			bytesWritten = dest_len;
			return result;
		}
	}
}
