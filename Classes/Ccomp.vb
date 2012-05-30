Imports System.IO
Imports System.IO.Compression

Public Class CComp

    ''' <summary>
    '''  Byte to Byte compression.
    ''' </summary>
    ''' <param name="byteSource"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CompressByte(ByVal byteSource() As Byte) As Byte()

        ' Create and GZipStream objects and memory stream object to store compressed stream
        Dim objMemStream As New MemoryStream()
        Dim objGZipStream As New GZipStream(objMemStream, CompressionMode.Compress, True)

        objGZipStream.Write(byteSource, 0, byteSource.Length)
        objGZipStream.Dispose()

        objMemStream.Position = 0

        ' Write compressed memory stream into byte array
        Dim buffer(objMemStream.Length) As Byte
        objMemStream.Read(buffer, 0, buffer.Length)
        objMemStream.Dispose()

        Return buffer

    End Function



    ''' <summary>
    ''' Byte to stream compression.
    ''' </summary>
    ''' <param name="byteSource"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CompressData(ByVal byteSource As Byte()) As MemoryStream

        ' Create the streams and byte arrays needed
        Dim byteBuffer As Byte() = Nothing
        Dim objSourceMemStream As MemoryStream = Nothing
        Dim objDestinationStream As New MemoryStream

        Dim compressedStream As GZipStream = Nothing

        objSourceMemStream = New MemoryStream(byteSource)

        ' Read the source stream values into the buffer
        byteBuffer = New Byte(objSourceMemStream.Length) {}

        Dim checkCounter As Integer = objSourceMemStream.Read(byteBuffer, 0, byteBuffer.Length)

        ' Create a compression stream pointing to the destiantion stream
        compressedStream = New GZipStream(objDestinationStream, CompressionMode.Compress, True)

        ' close all streams
        If Not (objSourceMemStream Is Nothing) Then
            objSourceMemStream.Close()
        End If
        If Not (compressedStream Is Nothing) Then
            compressedStream.Close()
        End If
        If Not (objDestinationStream Is Nothing) Then
            objDestinationStream.Close()
        End If

        ' Return compressed array of bytes 
        Return objDestinationStream

    End Function


End Class
