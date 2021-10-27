package com.keepcodingpl.eatwell.mypostsfragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.databinding.FragmentMyPostsBinding

class MyPostsFragment : Fragment(R.layout.fragment_my_posts) {

    private lateinit var postBinding: FragmentMyPostsBinding

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        postBinding = FragmentMyPostsBinding.inflate(inflater, container, false)
        return postBinding.root
    }

}