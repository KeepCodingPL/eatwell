package com.keepcodingpl.eatwell.main_fragment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.google.android.material.tabs.TabLayoutMediator
import com.keepcodingpl.eatwell.R
import com.keepcodingpl.eatwell.adapter.ViewPagerAdapter
import com.keepcodingpl.eatwell.databinding.FragmentMainBinding

class MainFragment : Fragment(R.layout.fragment_main) {

    private lateinit var mainBinding: FragmentMainBinding

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        mainBinding = FragmentMainBinding.inflate(inflater, container, false)
        return mainBinding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        setup()
    }

    private fun setup() {
        val tabLayout = mainBinding.tabLayout
        val viewpager = mainBinding.viewPager2

        val adapter = ViewPagerAdapter(childFragmentManager, lifecycle)
        viewpager.adapter = adapter

        TabLayoutMediator(tabLayout, viewpager) { tab, position ->
            when(position) {
                0 -> {
                    tab.text = "Feed"
                }
                1 -> {
                    tab.text = "My Posts"
                }
            }
        }.attach()
    }

}