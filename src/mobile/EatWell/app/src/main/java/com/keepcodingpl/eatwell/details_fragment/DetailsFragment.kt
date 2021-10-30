package com.keepcodingpl.eatwell.details_fragment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.databinding.FragmentDetailsBinding

class DetailsFragment : Fragment(R.layout.fragment_details) {

    private lateinit var viewModel: DetailsViewModel
    private var mealName = ""
    private lateinit var detailsBinding: FragmentDetailsBinding

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        detailsBinding = FragmentDetailsBinding.inflate(inflater, container, false)
        return detailsBinding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        arguments?.let {
            mealName = DetailsFragmentArgs.fromBundle(it).mealName
        }

        detailsBinding.productNameDetailsText.text = mealName

        // We can get vegan or halal details from api, and if it is true we can set checkbox here.
        // Default, all checkboxes not checked. Also boxes not clickable in detail screen.
        detailsBinding.veganDetailsCheckBox.isChecked = true

        // After added get method for details, we can use here.
        //viewModel = ViewModelProvider(this).get(DetailsViewModel::class.java)
        //viewModel.getDetailsFromAPI()
        //observeData()
    }

    private fun observeData() {
        viewModel.meal.observe(viewLifecycleOwner, { meal ->
            meal?.let {
                // After getting details from API.
            }
        })
    }

}