package com.keepcodingpl.eatwell.model

import android.os.Parcelable

@kotlinx.parcelize.Parcelize
data class Post(
    val postName: String,
    val postCategory: String
) : Parcelable

