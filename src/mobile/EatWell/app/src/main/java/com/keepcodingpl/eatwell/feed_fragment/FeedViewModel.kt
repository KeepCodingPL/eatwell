package com.keepcodingpl.eatwell.feed_fragment

import android.app.Application
import androidx.lifecycle.AndroidViewModel
import androidx.lifecycle.MutableLiveData
import com.keepcodingpl.eatwell.model.Meal
import com.keepcodingpl.eatwell.service.MealAPIService
import io.reactivex.android.schedulers.AndroidSchedulers
import io.reactivex.disposables.CompositeDisposable
import io.reactivex.observers.DisposableSingleObserver
import io.reactivex.schedulers.Schedulers

class FeedViewModel(application: Application) : AndroidViewModel(application)  {

    private val apiClient = MealAPIService()
    private val disposable = CompositeDisposable()
    val meals = MutableLiveData<List<Meal>>()


    fun getDataFromAPI() {


        disposable.add(
            apiClient.getData()
                .subscribeOn(Schedulers.newThread())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribeWith(object : DisposableSingleObserver<List<Meal>>(){
                    override fun onSuccess(t: List<Meal>) {
                        meals.value=t
//                        storeInSQLite(t)
//                        Toast.makeText(getApplication(),"Countries From API",Toast.LENGTH_LONG).show()
                    }

                    override fun onError(e: Throwable) {
//                        countryLoading.value = false
//                        countryError.value = true
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