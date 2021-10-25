package com.keepcodingpl.eatwell.model

import android.os.Parcelable
import com.google.gson.annotations.SerializedName
import kotlinx.android.parcel.Parcelize

@kotlinx.parcelize.Parcelize
data class Meal(

    @SerializedName("name")
    val mealName: String?,

    val malzemelerName: String?,

    val tarifi: String?,

    val resim: String?
):Parcelable



