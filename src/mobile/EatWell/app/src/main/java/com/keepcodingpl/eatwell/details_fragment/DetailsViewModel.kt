package com.keepcodingpl.eatwell.details_fragment

import android.app.Application
import androidx.lifecycle.AndroidViewModel
import androidx.lifecycle.MutableLiveData
import com.keepcodingpl.eatwell.model.Meal
import com.keepcodingpl.eatwell.service.MealAPIService
import io.reactivex.android.schedulers.AndroidSchedulers
import io.reactivex.disposables.CompositeDisposable
import io.reactivex.observers.DisposableSingleObserver
import io.reactivex.schedulers.Schedulers

class DetailsViewModel(application: Application) : AndroidViewModel(application) {

    private val apiClient = MealAPIService()
    private val disposable = CompositeDisposable()
    val meal = MutableLiveData<Meal>()

    fun getDetailsFromAPI() {

        disposable.add(
            apiClient.getDetails()
                .subscribeOn(Schedulers.newThread())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribeWith(object : DisposableSingleObserver<Meal>() {
                    override fun onSuccess(t: Meal) {
                        meal.value = t
                    }

                    override fun onError(e: Throwable) {
                        e.printStackTrace()
                    }
                })
        )
    }

    override fun onCleared() {
        super.onCleared()
        disposable.clear()
    }

}