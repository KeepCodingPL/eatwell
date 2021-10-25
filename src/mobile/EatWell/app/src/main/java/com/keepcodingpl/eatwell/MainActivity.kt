package com.keepcodingpl.eatwell

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.core.splashscreen.SplashScreen.Companion.installSplashScreen
import com.keepcodingpl.eatwell.adapter.ViewPagerAdapter
import com.keepcodingpl.eatwell.databinding.ActivityMainBinding
import com.keepcodingpl.eatwell.feed_fragment.FeedFragment
import com.keepcodingpl.eatwell.mypostsfragment.MyPostsFragment

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private val viewPagerAdapter = ViewPagerAdapter(supportFragmentManager)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        // Handle the splash screen transition.
        val splashScreen = installSplashScreen()
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        createViewPager()
    }

    private fun createViewPager() {
        viewPagerAdapter.addFragment(FeedFragment(), "FEED")
        viewPagerAdapter.addFragment(MyPostsFragment(), "MY POSTS")
        binding.viewPager.adapter = viewPagerAdapter
        binding.tabLayout.setupWithViewPager(binding.viewPager)
    }

}