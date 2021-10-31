package com.keepcodingpl.eatwell.service


import com.keepcodingpl.eatwell.utils.BASE_URL
import retrofit2.Retrofit
import retrofit2.adapter.rxjava2.RxJava2CallAdapterFactory
import retrofit2.converter.gson.GsonConverterFactory

class APIService {
    //https://raw.githubusercontent.com/Fatih-Baser/mealsjson/master/db.json

    val api =
        Retrofit.Builder().baseUrl(BASE_URL)
            .addConverterFactory(GsonConverterFactory.create())
            .addCallAdapterFactory(RxJava2CallAdapterFactory.create())
            .build().create(EatWellApi::class.java)
}