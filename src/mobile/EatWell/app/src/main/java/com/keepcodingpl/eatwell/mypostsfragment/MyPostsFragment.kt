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
import com.keepcodingpl.eatwell.mypostsfragment.adapter.MyPostAdapter
import com.keepcodingpl.eatwell.utils.SwipeToDeleteCallback

class MyPostsFragment : Fragment(R.layout.fragment_my_posts) {

    private lateinit var postBinding: FragmentMyPostsBinding

    private var postAdapter = MyPostAdapter(arrayListOf())



    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        postBinding = FragmentMyPostsBinding.inflate(inflater, container, false)
        return postBinding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        setupRv()
    }

    private fun setupRv() {
        postBinding.postRv.layoutManager = LinearLayoutManager(context)


        postBinding.postRv.adapter = postAdapter

        val swipeDelete = object : SwipeToDeleteCallback(requireContext()) {
            override fun onSwiped(
                viewHolder: RecyclerView.ViewHolder,
                direction: Int
            ) {
                val position = viewHolder.adapterPosition
                postAdapter.deleteItem(position)
                postAdapter.list.removeAt(position)

                //here the delete operation from the view model will be applied
            }
        }

        val touchHelper = ItemTouchHelper(swipeDelete)
        touchHelper.attachToRecyclerView(postBinding.postRv)
    }

}