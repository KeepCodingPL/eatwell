package com.keepcodingpl.eatwell.mypostsfragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.recyclerview.widget.ItemTouchHelper
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.databinding.FragmentMyPostsBinding
import com.keepcodingpl.eatwell.utils.SwipeToDeleteCallback

class MyPostsFragment : Fragment(R.layout.fragment_my_posts) {

    private var _binding: FragmentMyPostsBinding? = null
    private val binding get() = _binding!!

    private var postAdapter = MyPostAdapter()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentMyPostsBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        setupRv()
    }

    private fun setupRv() {
        binding.postRv.layoutManager = LinearLayoutManager(context)

        binding.postRv.adapter = postAdapter


        val swipeDelete = object : SwipeToDeleteCallback(requireContext()) {
            override fun onSwiped(
                viewHolder: RecyclerView.ViewHolder,
                direction: Int
            ) {
                val position = viewHolder.adapterPosition
                postAdapter.deleteElement(position)

                //here the delete operation from the view model will be applied
            }
        }

        val touchHelper = ItemTouchHelper(swipeDelete)
        touchHelper.attachToRecyclerView(binding.postRv)
    }
    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}

