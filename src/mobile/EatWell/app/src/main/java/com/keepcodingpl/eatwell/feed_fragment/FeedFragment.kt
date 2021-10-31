package com.keepcodingpl.eatwell.feed_fragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import androidx.navigation.NavController
import androidx.navigation.fragment.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.databinding.FragmentFeedBinding
import com.keepcodingpl.eatwell.feed_fragment.adapter.FeedFragmentAdapter
import com.keepcodingpl.eatwell.main_fragment.MainFragmentDirections
import com.keepcodingpl.eatwell.model.Meal

class FeedFragment : Fragment(R.layout.fragment_feed) {

    private lateinit var feedBinding: FragmentFeedBinding

    private lateinit var viewModel: FeedViewModel

    private var mealAdapter = FeedFragmentAdapter(arrayListOf())

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        feedBinding = FragmentFeedBinding.inflate(inflater, container, false)
        return feedBinding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
//        viewModel = ViewModelProvider(this).get(FeedViewModel::class.java)
//        viewModel.getDataFromAPI()
//        setupRv()
//        observeData()
//
//        viewModel.pushPost(Meal("dfafdsa","dfsafdsa",true,true,true))
//
        feedBinding.floatingActionButton.setOnClickListener {
            findNavController().navigate(MainFragmentDirections.actionMainFragmentToAddProductFragment())
        }
    }

//    private fun setupRv() {
//        feedBinding.mealsList.layoutManager = LinearLayoutManager(context)
//        feedBinding.mealsList.adapter = mealAdapter
//    }
//
//    private fun observeData() {
//        viewModel.meals.observe(viewLifecycleOwner, { meal ->
//            meal?.let {
//                feedBinding.mealsList.visibility = View.VISIBLE
//                mealAdapter.updateList(meal)
//            }
//        })
//    }
}