package com.keepcodingpl.eatwell.model

import com.google.gson.annotations.SerializedName

data class Meal(

    @SerializedName("image")
    val image: String,
    @SerializedName("name")
    val name: String?,
    @SerializedName("brand")
    val brand: String?,
    @SerializedName("isVegan")
    val isVegan: Boolean?,
    @SerializedName("isVegetarian")
    val isVegetarian: Boolean?,
    @SerializedName("isHalal")
    val isHalal: Boolean?
)



