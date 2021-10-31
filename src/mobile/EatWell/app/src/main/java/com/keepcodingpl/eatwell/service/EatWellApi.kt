package com.keepcodingpl.eatwell.service

import okhttp3.RequestBody
import okhttp3.ResponseBody
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.POST

interface EatWellApi {

    @POST("/api/product")
    suspend fun addProduct(@Body requestBody: RequestBody): Response<ResponseBody>

    //TODO: Get metodu calistiktan sonra bu kisim yapilacak
    @DELETE("/api/product")
    suspend fun deleteProduct(@Body requestBody: RequestBody): Response<ResponseBody>
}
