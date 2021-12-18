package com.keepcodingpl.eatwell.adapter

import androidx.fragment.app.Fragment
import androidx.fragment.app.FragmentManager
import androidx.lifecycle.Lifecycle
import androidx.viewpager2.adapter.FragmentStateAdapter
import com.keepcodingpl.eatwell.feed_fragment.FeedFragment
import com.keepcodingpl.eatwell.mypostsfragment.MyPostsFragment

class ViewPagerAdapter(fm : FragmentManager, lifecycle: Lifecycle) : FragmentStateAdapter(fm, lifecycle) {

    override fun getItemCount(): Int = 2

    override fun createFragment(position: Int): Fragment {

        return when(position) {
            0 -> {
                FeedFragment()
            }

            1 -> {
                MyPostsFragment()
            }

            else -> {
                Fragment()
            }
        }
    }
}