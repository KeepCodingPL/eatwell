package com.keepcodingpl.eatwell.feed_fragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.navigation.fragment.findNavController
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.databinding.FragmentFeedBinding
import com.keepcodingpl.eatwell.feed_fragment.adapter.FeedFragmentAdapter
import com.keepcodingpl.eatwell.main_fragment.MainFragmentDirections

class FeedFragment : Fragment(R.layout.fragment_feed) {

    private var _binding: FragmentFeedBinding? = null
    private val binding get() = _binding!!


    private lateinit var viewModel: FeedViewModel

    private var mealAdapter = FeedFragmentAdapter()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentFeedBinding.inflate(inflater, container, false)
        return binding.root
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
        binding.floatingActionButton.setOnClickListener {
            findNavController().navigate(MainFragmentDirections.actionMainFragmentToAddProductFragment())
        }
    }

//  private fun setupRv() {
//       binding.mealsList.layoutManager = LinearLayoutManager(context)
//       binding.mealsList.adapter = mealAdapter
    //   }

    //   private fun observeData() {
    //      viewModel.mealsResponse.observe(viewLifecycleOwner, { meal ->
    //         meal?.let {
    //              binding.mealsList.visibility = View.VISIBLE
    //           mealAdapter.meals = meal.mealList
    //   }
//   })
// }
    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}