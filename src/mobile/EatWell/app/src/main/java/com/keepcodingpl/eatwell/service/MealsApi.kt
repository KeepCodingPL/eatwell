package com.keepcodingpl.eatwell.service

import com.keepcodingpl.eatwell.model.Meal
import io.reactivex.Single
import retrofit2.http.GET

interface MealsApi {

    //get
    //post
    //https://raw.githubusercontent.com/Fatih-Baser/mealsjson/master/db.json
    @GET("Fatih-Baser/mealsjson/master/db.json")
    fun getMeals(): Single<List<Meal>>

    // For getting just one product for details.
    @GET()
    fun getMealDetail() : Single<Meal>


}
