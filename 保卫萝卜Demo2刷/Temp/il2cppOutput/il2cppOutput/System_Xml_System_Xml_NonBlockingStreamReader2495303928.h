﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_IO_TextReader283511965.h"

// System.Byte[]
struct ByteU5BU5D_t4116647657;
// System.Char[]
struct CharU5BU5D_t3528271667;
// System.Text.Encoding
struct Encoding_t1523322056;
// System.Text.Decoder
struct Decoder_t2204182725;
// System.IO.Stream
struct Stream_t1273022909;
// System.Text.StringBuilder
struct StringBuilder_t1712802186;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.NonBlockingStreamReader
struct  NonBlockingStreamReader_t2495303928  : public TextReader_t283511965
{
public:
	// System.Byte[] System.Xml.NonBlockingStreamReader::input_buffer
	ByteU5BU5D_t4116647657* ___input_buffer_1;
	// System.Char[] System.Xml.NonBlockingStreamReader::decoded_buffer
	CharU5BU5D_t3528271667* ___decoded_buffer_2;
	// System.Int32 System.Xml.NonBlockingStreamReader::decoded_count
	int32_t ___decoded_count_3;
	// System.Int32 System.Xml.NonBlockingStreamReader::pos
	int32_t ___pos_4;
	// System.Int32 System.Xml.NonBlockingStreamReader::buffer_size
	int32_t ___buffer_size_5;
	// System.Text.Encoding System.Xml.NonBlockingStreamReader::encoding
	Encoding_t1523322056 * ___encoding_6;
	// System.Text.Decoder System.Xml.NonBlockingStreamReader::decoder
	Decoder_t2204182725 * ___decoder_7;
	// System.IO.Stream System.Xml.NonBlockingStreamReader::base_stream
	Stream_t1273022909 * ___base_stream_8;
	// System.Boolean System.Xml.NonBlockingStreamReader::mayBlock
	bool ___mayBlock_9;
	// System.Text.StringBuilder System.Xml.NonBlockingStreamReader::line_builder
	StringBuilder_t1712802186 * ___line_builder_10;
	// System.Boolean System.Xml.NonBlockingStreamReader::foundCR
	bool ___foundCR_11;

public:
	inline static int32_t get_offset_of_input_buffer_1() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___input_buffer_1)); }
	inline ByteU5BU5D_t4116647657* get_input_buffer_1() const { return ___input_buffer_1; }
	inline ByteU5BU5D_t4116647657** get_address_of_input_buffer_1() { return &___input_buffer_1; }
	inline void set_input_buffer_1(ByteU5BU5D_t4116647657* value)
	{
		___input_buffer_1 = value;
		Il2CppCodeGenWriteBarrier(&___input_buffer_1, value);
	}

	inline static int32_t get_offset_of_decoded_buffer_2() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___decoded_buffer_2)); }
	inline CharU5BU5D_t3528271667* get_decoded_buffer_2() const { return ___decoded_buffer_2; }
	inline CharU5BU5D_t3528271667** get_address_of_decoded_buffer_2() { return &___decoded_buffer_2; }
	inline void set_decoded_buffer_2(CharU5BU5D_t3528271667* value)
	{
		___decoded_buffer_2 = value;
		Il2CppCodeGenWriteBarrier(&___decoded_buffer_2, value);
	}

	inline static int32_t get_offset_of_decoded_count_3() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___decoded_count_3)); }
	inline int32_t get_decoded_count_3() const { return ___decoded_count_3; }
	inline int32_t* get_address_of_decoded_count_3() { return &___decoded_count_3; }
	inline void set_decoded_count_3(int32_t value)
	{
		___decoded_count_3 = value;
	}

	inline static int32_t get_offset_of_pos_4() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___pos_4)); }
	inline int32_t get_pos_4() const { return ___pos_4; }
	inline int32_t* get_address_of_pos_4() { return &___pos_4; }
	inline void set_pos_4(int32_t value)
	{
		___pos_4 = value;
	}

	inline static int32_t get_offset_of_buffer_size_5() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___buffer_size_5)); }
	inline int32_t get_buffer_size_5() const { return ___buffer_size_5; }
	inline int32_t* get_address_of_buffer_size_5() { return &___buffer_size_5; }
	inline void set_buffer_size_5(int32_t value)
	{
		___buffer_size_5 = value;
	}

	inline static int32_t get_offset_of_encoding_6() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___encoding_6)); }
	inline Encoding_t1523322056 * get_encoding_6() const { return ___encoding_6; }
	inline Encoding_t1523322056 ** get_address_of_encoding_6() { return &___encoding_6; }
	inline void set_encoding_6(Encoding_t1523322056 * value)
	{
		___encoding_6 = value;
		Il2CppCodeGenWriteBarrier(&___encoding_6, value);
	}

	inline static int32_t get_offset_of_decoder_7() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___decoder_7)); }
	inline Decoder_t2204182725 * get_decoder_7() const { return ___decoder_7; }
	inline Decoder_t2204182725 ** get_address_of_decoder_7() { return &___decoder_7; }
	inline void set_decoder_7(Decoder_t2204182725 * value)
	{
		___decoder_7 = value;
		Il2CppCodeGenWriteBarrier(&___decoder_7, value);
	}

	inline static int32_t get_offset_of_base_stream_8() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___base_stream_8)); }
	inline Stream_t1273022909 * get_base_stream_8() const { return ___base_stream_8; }
	inline Stream_t1273022909 ** get_address_of_base_stream_8() { return &___base_stream_8; }
	inline void set_base_stream_8(Stream_t1273022909 * value)
	{
		___base_stream_8 = value;
		Il2CppCodeGenWriteBarrier(&___base_stream_8, value);
	}

	inline static int32_t get_offset_of_mayBlock_9() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___mayBlock_9)); }
	inline bool get_mayBlock_9() const { return ___mayBlock_9; }
	inline bool* get_address_of_mayBlock_9() { return &___mayBlock_9; }
	inline void set_mayBlock_9(bool value)
	{
		___mayBlock_9 = value;
	}

	inline static int32_t get_offset_of_line_builder_10() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___line_builder_10)); }
	inline StringBuilder_t1712802186 * get_line_builder_10() const { return ___line_builder_10; }
	inline StringBuilder_t1712802186 ** get_address_of_line_builder_10() { return &___line_builder_10; }
	inline void set_line_builder_10(StringBuilder_t1712802186 * value)
	{
		___line_builder_10 = value;
		Il2CppCodeGenWriteBarrier(&___line_builder_10, value);
	}

	inline static int32_t get_offset_of_foundCR_11() { return static_cast<int32_t>(offsetof(NonBlockingStreamReader_t2495303928, ___foundCR_11)); }
	inline bool get_foundCR_11() const { return ___foundCR_11; }
	inline bool* get_address_of_foundCR_11() { return &___foundCR_11; }
	inline void set_foundCR_11(bool value)
	{
		___foundCR_11 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
