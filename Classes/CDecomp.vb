Imports System.IO
Imports System.IO.Compression

Public Class CDecomp

    ''' <summary>
    ''' Decompress the byte array (compressed) by using GZipStream class library.
    ''' </summary>
    ''' <param name="byteCompressed">Compressed Byte()</param>
    ''' <returns>Decompressed Byte()</returns>
    ''' <remarks></remarks>
    Public Function DecompressByte(ByVal byteCompressed() As Byte) As Byte()

        Try
            ' Initialize memory stream with byte array.
            Dim objMemStream As New MemoryStream(byteCompressed)

            ' Initialize GZipStream object with memory stream.
            Dim objGZipStream As New GZipStream(objMemStream, CompressionMode.Decompress)

            ' Define a byte array to store header part from compressed stream.
            Dim sizeBytes(3) As Byte

            ' Read the size of compressed stream.
            objMemStream.Position = objMemStream.Length - 5
            objMemStream.Read(sizeBytes, 0, 4)

            Dim iOutputSize As Integer = BitConverter.ToInt32(sizeBytes, 0)

            ' Posistion the to point at beginning of the memory stream to read 
            ' compressed stream for decompression.
            objMemStream.Position = 0

            Dim decompressedBytes(iOutputSize - 1) As Byte

            ' Read the decompress bytes and write it into result byte array.
            objGZipStream.Read(decompressedBytes, 0, iOutputSize)

            objGZipStream.Dispose()
            objMemStream.Dispose()

            Return decompressedBytes

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    ''' <summary>
    ''' Function to decompress the memory stream(compressed) by using GZipStream class library.
    ''' Note that, it is important for the caller to do the compressing with GZipStream.
    ''' </summary>
    ''' <param name="compressedStream">MemoryStream (compressed)</param>
    ''' <param name="buffLength">Required size of result byte()</param>
    ''' <returns>Byte() (decompressed)</returns>
    ''' <remarks></remarks>
    Public Function DecompressData(ByVal compressedStream As MemoryStream, ByVal buffLength As ULong) As Byte()
        ' Reset the memory stream position to begin decompression.
        compressedStream.Position = 0

        Dim zipStream As New GZipStream(compressedStream, CompressionMode.Decompress)

        Dim decompressedBuffer(buffLength + 100) As Byte

        ' Use the ReadAllBytesFromStream to read the stream.
        Dim totalCount As Integer = ReadAllBytesFromStream(zipStream, decompressedBuffer)

        Return decompressedBuffer
    End Function


    ''' <summary>
    ''' To get size of byte of the memory stream.
    ''' </summary>
    ''' <param name="stream">Input memory stream</param>
    ''' <param name="buffer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadAllBytesFromStream(ByVal stream As Stream, ByVal buffer As Byte()) As Integer
        ' Use this method is used to read all bytes from a stream.
        Dim offset As Integer = 0
        Dim totalCount As Integer = 0

        While True
            Dim bytesRead As Integer = stream.Read(buffer, offset, 100)
            If bytesRead = 0 Then
                Exit While
            End If
            offset += bytesRead
            totalCount += bytesRead
        End While
        Return totalCount
    End Function 'ReadAllBytesFromStream
End Class
