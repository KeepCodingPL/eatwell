package com.keepcodingpl.eatwell.add_product

import android.os.Bundle
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.databinding.AddProductFragmentBinding
import com.keepcodingpl.eatwell.service.APIService
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.RequestBody.Companion.toRequestBody
import org.json.JSONObject

class AddProductFragment : Fragment(R.layout.add_product_fragment) {

    private var apiService = APIService()
    private lateinit var binding: AddProductFragmentBinding

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        binding = AddProductFragmentBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        val jsonObject = JSONObject()
        jsonObject.put("name", binding.editTextName.text.toString())
        jsonObject.put("brand", binding.editTextBrand.text.toString())
        jsonObject.put("isVegan", binding.checkboxVegan.isChecked)
        jsonObject.put("isVegetarian", binding.checkboxVegetarian.isChecked)
        jsonObject.put("isHalal", binding.checkboxHalal.isChecked)

        binding.buttonSendProduct.setOnClickListener {

            val jsonObjectString = jsonObject.toString()
            val requestBody = jsonObjectString.toRequestBody("application/json".toMediaTypeOrNull())

            CoroutineScope(Dispatchers.IO).launch {
                // Do the POST request and get response
                val response = apiService.api.addProduct(requestBody)
                withContext(Dispatchers.Main) {
                    if (response.isSuccessful) {
                        Log.d("aa", response.code().toString())
                        Log.d("aa", response.body().toString())
                        Log.d("aa", response.message().toString())
                    } else {
                        Log.d("aa", response.code().toString())
                        Log.d("aa", response.body().toString())
                        Log.d("aa", response.message().toString())
                    }
                }
            }
        }

        fun uploadPost() {

        }

    }

}