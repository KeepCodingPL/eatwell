package com.keepcodingpl.eatwell.service

import com.keepcodingpl.eatwell.model.Meal
import io.reactivex.Single
import retrofit2.http.GET

interface MealsApı {

    //get
    //post
    //https://raw.githubusercontent.com/Fatih-Baser/mealsjson/master/db.json
    @GET("Fatih-Baser/mealsjson/master/db.json")
    fun getMeals(): Single<List<Meal>>


}
