package com.keepcodingpl.eatwell.feed_fragment

import android.app.Application
import androidx.lifecycle.AndroidViewModel
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.viewModelScope
import com.keepcodingpl.eatwell.model.Meal
import com.keepcodingpl.eatwell.service.APIService
import io.reactivex.android.schedulers.AndroidSchedulers
import io.reactivex.disposables.CompositeDisposable
import io.reactivex.observers.DisposableSingleObserver
import io.reactivex.schedulers.Schedulers
import kotlinx.coroutines.launch
import retrofit2.Response

class FeedViewModel(application: Application) : AndroidViewModel(application) {

    private val apiClient = APIService()
    private val disposable = CompositeDisposable()
    val meals = MutableLiveData<List<Meal>>()


//    fun getDataFromAPI() {
//        disposable.add(
//            apiClient.getData()
//                .subscribeOn(Schedulers.newThread())
//                .observeOn(AndroidSchedulers.mainThread())
//                .subscribeWith(object : DisposableSingleObserver<List<Meal>>() {
//                    override fun onSuccess(t: List<Meal>) {
//                        meals.value = t
//                    }
//
//                    override fun onError(e: Throwable) {
//
//                        e.printStackTrace()
//                    }
//                })
//        )
//    }

//    suspend fun addProduct(){
//           apiClient.postProduct(Meal("dsadafs","fdsafdsa",true,true,true))
//    }

//    fun pushPost(meal: Meal) {
//        viewModelScope.launch {
//            val response = apiClient.postProduct(meal)
//            myResponse.value = response
//        }
//    }

//
//    override fun onCleared() {
//        super.onCleared()
//        disposable.clear()
//    }
}