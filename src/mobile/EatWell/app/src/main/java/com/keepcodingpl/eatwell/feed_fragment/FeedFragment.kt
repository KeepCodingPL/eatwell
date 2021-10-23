package com.keepcodingpl.eatwell.feed_fragment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.lifecycle.ViewModelProviders
import com.keepcodingpl.eatwell.R

class FeedFragment : Fragment() {

    private lateinit var viewModel:FeedViewModel
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_feed, container, false)
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {

        viewModel= ViewModelProviders.of(this).get(FeedViewModel::class.java)
        viewModel.getDataFromAPI()

        super.onViewCreated(view, savedInstanceState)
    }

}